using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fitzone.EF.Migrations
{
    /// <inheritdoc />
    public partial class Agregarsociosmigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                       
                            GO

                            INSERT INTO [dbo].[Socio]
                                       ([nombre]
                                       ,[apellido]
                                       ,[numeroDocumento]
                                       ,[telefono1]
                                       ,[telefono2]
                                       ,[mail]
                                       ,[tipoDocumento]
                                       ,[calle]
                                       ,[calleNumero]
                                       ,[idBarrio])
                                 VALUES
                                       ('Paola Andrea'
                                       ,'Cornejo'
                                       ,'27123456'
                                       ,'35161234'
                                       ,null
                                       ,'paola@gmail.com'
                                       ,'DNI'
                                       ,'Estados Unidos'
                                       ,'2215'
                                       ,1)
                            GO
                            
                            INSERT INTO [dbo].[Socio]
                                       ([nombre]
                                       ,[apellido]
                                       ,[numeroDocumento]
                                       ,[telefono1]
                                       ,[telefono2]
                                       ,[mail]
                                       ,[tipoDocumento]
                                       ,[calle]
                                       ,[calleNumero]
                                       ,[idBarrio])
                                 VALUES
                                       ('Abel'
                                       ,'Pintos'
                                       ,'123456779'
                                       ,'351687455'
                                       ,null
                                       ,'abel@gmail.com'
                                       ,'DNI'
                                       ,'San Martin'
                                       ,'4571'
                                       ,1)
                            GO
                    ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" truncate table  Socio  ;
                                --delete from departamento  ;
                                --DBCC CHECKIDENT (departamento , RESEED, 0);    ");
        }
    }
}
