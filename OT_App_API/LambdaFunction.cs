namespace OT_App_API
{
    public class LambdaFunction : Amazon.Lambda.AspNetCoreServer.APIGatewayProxyFunction
    {
        //[Obsolete]
        //protected override void Init(IWebHostBuilder builder)
        //{
        //    _ = builder.UseContentRoot(Directory.GetCurrentDirectory()).UseStartup().UseApiGateway();
        //}
    }
}
