using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Xamarin.Forms;
using Microsoft.EntityFrameworkCore;
using AppDemoDB7.Model;
using AppDemoDB7.Interfaces.SQLite;

namespace AppDemoDB7.Context
{
    public class FicGDBContext : DbContext
    {
        private readonly string FicDataBasePath;
        public DbSet<zt_cat_grupos> zt_cat_grupos { get; set; }
        public DbSet<zt_cat_productos> zt_cat_productos { get; set; }
        public DbSet<zt_cat_unidad_medidas> zt_cat_unidad_medidas { get; set; }


        protected async override void OnModelCreating(ModelBuilder FicModelBuilder)
        {
            try
            {

                #region Inventarios 
                /*CREACION DE LLAVES PRIMARIAS*/
                FicModelBuilder.Entity<zt_cat_grupos>()
                    .HasKey(c => c.IdGrupoSKU);

                FicModelBuilder.Entity<zt_cat_productos>()
                 .HasKey(c => c.IdSKU);

                FicModelBuilder.Entity<zt_cat_unidad_medidas>()
                 .HasKey(c => c.IdUnidadMedida);

                /*Llaves Foraneas*/

                FicModelBuilder.Entity<zt_cat_productos>()
                    .HasOne(s => s.zt_cat_grupos)
                    .WithMany().HasForeignKey(s => new { s.IdGrupoSKU });


                FicModelBuilder.Entity<zt_cat_productos>()
                    .HasOne(s => s.zt_cat_unidad_medidas)
                    .WithMany().HasForeignKey(s => new { s.IdUMedidaBase });

            }
            catch (Exception e)
            {
            }
        }
        public FicGDBContext(string FicDataBasePath)
        {
            this.FicDataBasePath = FicDataBasePath;
            FicMetCreateDataBase();
            this.Database.SetCommandTimeout(200);
        }//Builder

        private async void FicMetCreateDataBase()
        {
            try
            {
                await Database.EnsureCreatedAsync();
            }
            catch (Exception e)
            {
                await new Page().DisplayAlert("Alerta", e.Message.ToString(), "Ok");
            }
        }

        protected async override void OnConfiguring(DbContextOptionsBuilder FicOptionsBuilder)
        {
            try
            {
                if (!FicOptionsBuilder.IsConfigured)
                {

                    FicOptionsBuilder.UseSqlite($"Filename={FicDataBasePath}")
                            .EnableSensitiveDataLogging(true)
                            .EnableDetailedErrors(true)
                            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                    base.OnConfiguring(FicOptionsBuilder);
                }
            }
            catch (Exception e)
            {
                await new Page().DisplayAlert("Alerta", e.Message.ToString(), "Ok");
            }
        }
    }
}
#endregion
