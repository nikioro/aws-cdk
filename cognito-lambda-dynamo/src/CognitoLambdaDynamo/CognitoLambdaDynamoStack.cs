using Amazon.CDK;
using Amazon.CDK.AWS.IAM;
using Amazon.CDK.AWS.Lambda;
using Constructs;

namespace CognitoLambdaDynamo
{
    public class CognitoLambdaDynamoStack : Stack
    {
        internal CognitoLambdaDynamoStack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
        //    var myRole =   new Role(this, "My Cdk Role" , new RoleProps{ AssumedBy = new ServicePrincipal("sns.amazonaws.com") });
            Function fn = new Function(this, "My CDK Function", new FunctionProps
            {
                Runtime = Runtime.DOTNET_CORE_3_1,
                Handler = "FunctionHandler",
                Code = Code.FromAsset(
                    "src\\CognitoLambdaDynamo\\lambda-handler"),
                // Role =myRole
            });

            // myRole.AddManagedPolicy(ManagedPolicy.FromAwsManagedPolicyName("service-role/AWSLambdaBasicExecutionRole"));
            // myRole.AddManagedPolicy(ManagedPolicy.FromAwsManagedPolicyName("service-role/AWSLambdaVPCAccessExecutionRole")); // only required if your function lives in a VPC

        }
    }
}
