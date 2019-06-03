using ExampleGraphQL.Contracts;
using ExampleGraphQL.Types;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExampleGraphQL.Queries
{
    public class GuestQuery : ObjectGraphType
    {
        public GuestQuery(IGuestRepository guestRepository)
        {
            Field<ListGraphType<GuestType>>("guests",
                arguments: new QueryArguments(new List<QueryArgument>
                {
                    new QueryArgument<IntGraphType>
                    {
                        Name = "id"
                    },
                    new QueryArgument<StringGraphType>
                    {
                        Name = "firstName"
                    },
                    new QueryArgument<StringGraphType>
                    {
                        Name = "lastName"
                    },
                    new QueryArgument<DateTimeGraphType>
                    {
                        Name = "registerDate"
                    }
                }),
                resolve: context =>
                {
                    var query = guestRepository.GetGuests();

                    var guestId = context.GetArgument<int?>("id");
                    if (guestId.HasValue)
                    {
                        return query.Where(r => r.Id == guestId.Value);
                    }

                    var firstName = context.GetArgument<string>("firstName");
                    if (!string.IsNullOrEmpty(firstName))
                    {
                        return query.Where(r => r.FirstName == firstName);
                    }

                    var lastName = context.GetArgument<string>("lastName");
                    if (!string.IsNullOrEmpty(lastName))
                    {
                        return query.Where(r => r.LastName == lastName);
                    }

                    var registerDate = context.GetArgument<DateTime?>("registerDate");
                    if (registerDate.HasValue)
                    {
                        return query.Where(r => r.RegisterDate == registerDate.Value);
                    }

                    return query.ToList();
                }
            );
        }
    }
}
