using TodoApi;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration["ToDoDB"];
builder.Services.AddDbContext<ToDoDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();

app.MapGet("/items", async (ToDoDbContext db) => {
    return await db.Items.ToListAsync();
});

app.MapPost("/items",async (ToDoDbContext db, Item item) => {
    db.Items.Add(item);
    await db.SaveChangesAsync();
    return Results.Created($"/items/{item.Id}", item);
});

app.MapPut("/items/{id}",async (int id, Item updatedItem, ToDoDbContext db) => {
    var task = await db.Items.FindAsync(id);
    if (task == null) {
        return Results.NotFound();
    }
    task.Name = updatedItem.Name;
    task.IsComplete = updatedItem.IsComplete;
   
    await db.SaveChangesAsync();
    return Results.Ok(task); 
});

app.MapDelete("/items/{id}", async (int id, ToDoDbContext db) => {
    var task = await db.Items.FindAsync(id);
    if (task == null) {
        return Results.NotFound(); 
    }

    db.Items.Remove(task);
    await db.SaveChangesAsync();
    return Results.Ok("task deleted successfully");
});

app.Run();