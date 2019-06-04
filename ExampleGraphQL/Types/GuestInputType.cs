using GraphQL.Types;

namespace ExampleGraphQL.Types
{
    public class GuestInputType : InputObjectGraphType
    {
        public GuestInputType()
        {
            Name = "GuestInput";

            Field<NonNullGraphType<IntGraphType>>("id");
            Field<NonNullGraphType<StringGraphType>>("firstName");
            Field<NonNullGraphType<StringGraphType>>("lastName");
            Field<NonNullGraphType<DateGraphType>>("registerData");
        }
    }
}
