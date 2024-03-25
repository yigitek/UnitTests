using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Tests
{
    public static class DumbestFunctionEverTest
    {
        //Naming: ClassName_MethodName_ExpectedResult
        public static void DumbestFunctionEver_ReturnsPikachuIfZero_ReturnsString()
        {
            try
            {
                //Arrange - Go get your variables,whatever you need; classes functions, get them
                int num = 0;
                DumbestFunctionEver dumbo = new DumbestFunctionEver();

                //Act - Execute the function
                string result = dumbo.ReturnsPikachuIfZero(num);

                //Assert - Whatever is returned is it what you want?
                if(result == "PIKACHU!")
                {
                    Console.WriteLine("PASSED: DumbestFunctionEver.ReturnsPikachuIfZero_ReturnsString");
                }
                else
                {
                    Console.WriteLine("FAILED: DumbestFunctionEver.ReturnsPikachuIfZero_ReturnsString");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
