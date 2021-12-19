using Amazon.CDK;
using Amazon.CDK.AWS.Lambda;
using Constructs;

namespace CognitoLambdaDynamo
{
    public class CognitoLambdaDynamoStack : Stack
    {
        internal CognitoLambdaDynamoStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            Function fn = new Function(this, "MyFunction", new FunctionProps
            {
                Runtime = Runtime.DOTNET_CORE_3_1,
                Handler = "index.handler",
                Code = Code.FromAsset(string.Join("", "lambda-handler"))
            });
        }
    }
}
