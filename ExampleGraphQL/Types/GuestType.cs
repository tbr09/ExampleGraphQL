using ExampleGraphQL.Models;
using GraphQL.Types;

namespace ExampleGraphQL.Types
{
    public class GuestType : ObjectGraphType<Guest>
    {
        public GuestType()
        {
            Field(x => x.Id);
            Field(x => x.FirstName);
            Field(x => x.LastName);
            Field(x => x.RegisterDate);
        }
    }
}
