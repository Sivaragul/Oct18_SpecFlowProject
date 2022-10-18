using NUnit.Framework;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public  class CalculatorStepDefinitions
    {
        string i, j;
        int k;
        string hq;
        int qh;
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the userid is (.*)")]
        public void GivenTheUseridIs(string userid)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            i = userid;
        }

        [Given("the password is (.*)")]
        public void GivenThePasswordIs(string password)
        {
            //TODO: implement arrange (precondition) logic

            j = password;
        }

        [When("successful login")]
        public void WhenSuccessfulLogin()
        {
            //TODO: implement act (action) logic

            Console.WriteLine($"{i}{j}");
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(string result)
        {
            string actual = null;
            //TODO: implement assert (verification) logic

            if ((i == "testuser_1" && j == "Test@123") || (i == "testuser_2" && j == "Test@153"))
            {
                actual = result;

            }
            else
            {
                actual = "Erroneous";
            }

            Assert.AreEqual(result, actual);
        }

        [Given("the input is (.*)")]

        public void GivenTheInputIs(int input)
        {
            k = input;
        }

        [When("successful logout")]
        public void WhenSuccessfulLogout()
        {
            //TODO: implement act (action) logic

            Console.WriteLine($"{k}");
        }
        [Then("the ans should be (.*)")]
        public void ThenTheAnsShouldBe(string result)
        {
            string actual = null;
            if (k == 1)
            {
                actual = result;

            }
            else
            {
                actual = "User was not logged in";
            }
            Assert.AreEqual(result, actual);
        }

        [Given("the prodname is (.*)")]

        public void GivenTheProdnameIs(string input)
        {
            hq = input;
        }
        [Given("the quantity is (.*)")]

        public void GivenTheQuantityIs(int input)
        {
            qh = input;
        }
        [When("Added to the cart")]
        public void WhenAddedToTheCart()
        {
            //TODO: implement act (action) logic

            Console.WriteLine($"{hq}{qh}");
        }
        [Then("the output should be (.*)")]
        public void ThenTheOutputShouldBe(string result)
        {
            string actual = null;
            if (qh > 0 && hq != null)
            {
                actual = result;

            }
            else
            {
                actual = "Not perfect to be added in";
            }
            Assert.AreEqual(result, actual);
        }
    }
}