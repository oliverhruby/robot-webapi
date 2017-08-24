using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Robot.Models;

namespace Robot.Data
{
    public static class DbInitializer
    {
        public static void Initialize(RobotContext context)
        {
            context.Database.EnsureCreated();

            // Look for any scenes.
            if (context.Scenes.Any())
            {
                return;   // DB has been seeded
            }

            var scenes = new Scene[]
            {
                new Scene { Title = "Scene 1" },
                new Scene { Title = "Scene 2" }
            };

            foreach (Scene s in scenes)
            {
                context.Scenes.Add(s);
            }
            context.SaveChanges();
        }
    }
}