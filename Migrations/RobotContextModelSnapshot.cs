﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Robot.Data;
using System;

namespace Robot.Migrations
{
    [DbContext(typeof(RobotContext))]
    partial class RobotContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Robot.Models.Person", b =>
                {
                    b.Property<int>("PersonID");

                    b.Property<string>("Title")
                        .HasMaxLength(50);

                    b.HasKey("PersonID");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Robot.Models.Scene", b =>
                {
                    b.Property<int>("SceneID");

                    b.Property<string>("Title")
                        .HasMaxLength(50);

                    b.HasKey("SceneID");

                    b.ToTable("Scenes");
                });
#pragma warning restore 612, 618
        }
    }
}
