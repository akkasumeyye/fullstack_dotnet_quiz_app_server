using Microsoft.Extensions.Hosting;
using QuizBusiness.Abstract;
using QuizBusiness.Concrete;
using QuizDataAccess.Abstract;
using QuizDataAccess.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddMvc();

builder.Services.AddSingleton<IParticipantDal, EfParticipantDal>();
builder.Services.AddSingleton<IQuestionDal, EfQuestionDal>();
builder.Services.AddSingleton<IQuestionService, QuestionManager>();
builder.Services.AddSingleton<IParticipantService, ParticipantManager>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints => { endpoints.MapControllers(); });


app.MapRazorPages();

app.Run();
