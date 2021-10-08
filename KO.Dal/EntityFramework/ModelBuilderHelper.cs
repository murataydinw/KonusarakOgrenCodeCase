using KO.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KO.Dal.EntityFramework
{
    public class ModelBuilderHelper
    {
        public static void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(x => x.Id, "user_id").IsUnique();
                entity.Property(a => a.Name);
                entity.Property(a => a.Surname);
                entity.Property(a => a.Email);
                entity.Property(a => a.Password);
            });
            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasIndex(x => x.Id, "article_id").IsUnique();
                entity.Property(a => a.Title);
                entity.Property(a => a.Body);
            });
            modelBuilder.Entity<Exam>(entity =>
            {
                entity.HasIndex(x => x.Id, "exam_id").IsUnique();
                entity.Property(a => a.Title);
                entity.Property(a => a.Body);
                entity.Property(a => a.Title);
                entity.Property(a => a.Body);
                entity.Property(a => a.QuestionOne);
                entity.Property(a => a.QuestionTwo);
                entity.Property(a => a.QuestionThree);
                entity.Property(a => a.QuestionFour);
                entity.Property(a => a.QOneAOne);
                entity.Property(a => a.QOneATwo);
                entity.Property(a => a.QOneAThree);
                entity.Property(a => a.QOneAFour);
                entity.Property(a => a.QOneTrue);
                entity.Property(a => a.QTwoAOne);
                entity.Property(a => a.QTwoATwo);
                entity.Property(a => a.QTwoAThree);
                entity.Property(a => a.QTwoAFour);
                entity.Property(a => a.QTwoTrue);
                entity.Property(a => a.QThreeAOne);
                entity.Property(a => a.QThreeATwo);
                entity.Property(a => a.QThreeAThree);
                entity.Property(a => a.QThreeAFour);
                entity.Property(a => a.QThreeTrue);
                entity.Property(a => a.QFourAOne);
                entity.Property(a => a.QFourATwo);
                entity.Property(a => a.QFourAThree);
                entity.Property(a => a.QFourAFour);
                entity.Property(a => a.QFourTrue);
                entity.Property(a => a.CreatedDate);
            });
        }
    }
}
