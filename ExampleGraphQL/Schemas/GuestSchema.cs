using ExampleGraphQL.Queries;
using GraphQL;
using GraphQL.Types;

namespace ExampleGraphQL.Schemas
{
    public class GuestSchema : Schema
    {
        public GuestSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<GuestQuery>();
        }
    }
}
