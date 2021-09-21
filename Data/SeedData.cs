using ApiRestProyecto.Data;
using ApiRestServidor.Modelos.Domicilio;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestServidor.Data
{
    /*
     * Este código consumira una gran cantidad de recursos al primer arranque del servidor, esto se debe a que se van a insertar cerca de 1300 registros. Si no desee realizar este
     * proceso vaya a la clase Program y elimine todo lo relacionado con SeedData. Cabe destacar que este proceso solo se ejecutara la primera vez que se arranque el servidor o que 
     * la BBDD haya sufrido algún cambio
     */
    public static class SeedData
    {
        public static void InitializeDepartamentos(IServiceProvider serviceProvider)
        {
            using (var context = new ServidorDbContext(serviceProvider.GetRequiredService<DbContextOptions<ServidorDbContext>>()))
            {
                if (context.Departamentos.Any())
                {
                    return;
                }

                context.Departamentos.AddRange(
                    new Departamento { Nombre = "Amazonas" },
                    new Departamento { Nombre = "Antioquia" },
                    new Departamento { Nombre = "Arauca" },
                    new Departamento { Nombre = "Atlántico" },
                    new Departamento { Nombre = "Bogotá" },
                    new Departamento { Nombre = "Bolívar" },
                    new Departamento { Nombre = "Boyacá" },
                    new Departamento { Nombre = "Caldas" },
                    new Departamento { Nombre = "Caquetá" },
                    new Departamento { Nombre = "Casanare" },
                    new Departamento { Nombre = "Cauca" },
                    new Departamento { Nombre = "Cesar" },
                    new Departamento { Nombre = "Chocó" },
                    new Departamento { Nombre = "Córdoba" },
                    new Departamento { Nombre = "Cundinamarca" },
                    new Departamento { Nombre = "Guainía" },
                    new Departamento { Nombre = "Guaviare" },
                    new Departamento { Nombre = "Huila" },
                    new Departamento { Nombre = "La Guajira" },
                    new Departamento { Nombre = "Magdalena" },
                    new Departamento { Nombre = "Meta" },
                    new Departamento { Nombre = "Nariño" },
                    new Departamento { Nombre = "Norte de Santander" },
                    new Departamento { Nombre = "Putumayo" },
                    new Departamento { Nombre = "Quindío" },
                    new Departamento { Nombre = "Risaralda" },
                    new Departamento { Nombre = "San Andrés y Providencia" },
                    new Departamento { Nombre = "Santander" },
                    new Departamento { Nombre = "Sucre" },
                    new Departamento { Nombre = "Tolima" },
                    new Departamento { Nombre = "Valle del Cauca" },
                    new Departamento { Nombre = "Vaupés" },
                    new Departamento { Nombre = "Vichada" }
                    );
                context.SaveChanges();


            }
        }

        public static void InitializeMunicipios(IServiceProvider serviceProvider)
        {
            using (var context = new ServidorDbContext(serviceProvider.GetRequiredService<DbContextOptions<ServidorDbContext>>()))
            {

                if (context.Municipios.Any())
                {
                    return;
                }
               
                if (context.Municipios.Any())
                {
                    return;
                }
                
                //Municipios del Amazonas
                var departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Amazonas") select departamento;
                int Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Encanto" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Chorrera" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Pedrera" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Leticia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Miriti-Paraná" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Alegría" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Arica" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Nariño" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Santander" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tarapacá" }
                    );
                //Municipios de Antioquia
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Antioquia") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cáceres" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Caucasia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Bagre" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Nechí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tarazá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Zaragoza" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Caracolí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Maceo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Berrío" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Nare" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Triunfo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Yondó" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Amalfi" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Anorí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cisneros" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Remedios" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Roque" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santo Domingo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Segovia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Vegachí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Yalí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Yolombó" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Angostura" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Belmira" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Briceño" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Campamento" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Carolina del Principe" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Donmatías" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Entrerríos" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Gómez Plata" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guadalupe" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ituango" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Andrés de Cuerquia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Jóse de la Montaña" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Pedro de los Milagros" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Rosa de Osos" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Toledo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Valdivia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Yarumal" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Abriaquí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Fe de Antioquia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Anzá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Armenia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Buriticá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Caicedo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cañasgordas" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Dabeiba" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ebéjico" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Frontino" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Giraldo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Heliconia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Liborina" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Olaya" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Peque" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sabanalarga" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Jéronimo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sopetrán" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Uramita" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Abejorral" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Alejandría" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Argelia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Carmen de Viboral" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cocorná" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Concepción" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Peñol" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El retiro" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Santuario" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Granada" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guarne" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guatapé" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Ceja" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Unión" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Marinilla" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Nariño" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Rionegro" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Carlos" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Francisco" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Luis" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Rafael" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Vicente" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sonsón" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Amagá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Andes" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Angelópolis" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Betania" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Betunia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Caramanta" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ciudad Bolivar" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Concordia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Fredonia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Hispania" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Jardín" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Jericó" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Pintada" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Montebello" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pueblorrico" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Salgar" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Bárbara" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Támesis" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tarso" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tiribirí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Urrao" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Valparaíso" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Venecia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Apartadó" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Arboretes" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Carepa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chigorodó" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Murindó" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Mutatá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Necoclí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Juan de Urabá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Pedro de Urabá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Turbo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Vigía del Fuerte" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Barbosa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Bello" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Caldas" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Copacabana" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Envigado" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Girardota" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Itagüí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Estrella" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Medellín" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sabaneta" }
                    );

                context.SaveChanges();


            }
        }
    }
}
