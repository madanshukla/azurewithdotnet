using CorewebAPIAzure;
using CorewebAPIAzure.Controllers;
namespace CorewebAPIAzure.Test;

public class UnitTest1
{
    [Fact] //Arrange Act Assert
    public void Test1()
    {
ValuesController values=new ValuesController();
var test=values.Get();
Assert.Equal(test,new string[] { "value12" });
    }
}