using GraphQLHotChocolate.GraphQL;
using GraphQLHotChocolate.Models;
using GraphQLHotChocolate.Services;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;
builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<Query>();
builder.Services.AddScoped<Mutation>();
builder.Services.AddGraphQLServer()
    .AddType<GraphQLTypes>()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();
var app = builder.Build();
app.MapGraphQL();
app.Run();


