using NSpec;
using System;
using System.Linq;

namespace NSpecPlayground
{
    public class describe_dummy : nspec
    {
        void it_should_pass()
        {
            true.should_be_true();
        }

        void it_should_fail()
        {
            true.should_be_false();
        }
    }
}
