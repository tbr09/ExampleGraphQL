using ExampleGraphQL.Contracts;
using ExampleGraphQL.Models;
using ExampleGraphQL.Types;
using GraphQL.Types;

namespace ExampleGraphQL.Mutations
{
    public class GuestMutation : ObjectGraphType
    {
        public GuestMutation(IGuestRepository guestRepository)
        {
            Field<GuestType>(
                "createItem",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<GuestInputType>> { Name = "guestInput" }
                ),
                resolve: context =>
                {
                    var item = context.GetArgument<Guest>("guestInput");
                    return guestRepository.AddGuest(item);
                });
        }
    }
}
