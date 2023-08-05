using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

public static class DbInitializer
{
    public static void Initialize(DataContext context)
    {
        // Применить миграции, если они еще не были применены
        context.Database.Migrate();

        // Добавьте здесь код для инициализации данных, если это необходимо
    }
}
