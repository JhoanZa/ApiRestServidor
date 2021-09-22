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


                //Municipios de Arauca
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Arauca") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Arauca" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Arauquita" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cravo Norte" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Fortul" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Rondón" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Saravena" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tame" }
                    );

                //Municipios de Atlántico
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Atlántico") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Barranquilla" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Baranoa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Campo de Luz" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Candelaria" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Galapa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Juan de Acosta" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Luruaco" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Malambo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Manatí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Palmar de Varela" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Piojó" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Polonuevo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ponedera" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Colombia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Repelón" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sabanagrande" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sabanalarga" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Lucía" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santo Tomás" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Soledad" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Suan" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tubará" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Usiacurí" }
                    );

                //Municipios de Bogotá
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Bogotá") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Usaquén" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chapinero" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Fe" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Cristóbal" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Usme" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tunjuelito" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Bosa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Kennedy" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Fontibón" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Engativá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Suba" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Barrios Unidos" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Teusaquillo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Los Mártires" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Antonio Nariño" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puente Aranda" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Candelaria" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Rafael Uribe Uribe" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ciudad Bolívar" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sumapaz" }
                    );

                //Municipios de Bolívar
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Bolívar") select departamento;
                Codigo = departamentoL.First().IdDepartamento;


                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Achí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Altos del rosario" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Arenal" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Arjona" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Arroyohondo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Barranco de Loba" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Calamar" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cantagallo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Carmen de Bolívar" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cartagena de Indias" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cicuco" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Clemencia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Córdoba" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Guamo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Peñon" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Hatillo de Loba" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Magangué" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Mahates" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Margarita" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Maria La Baja" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Montecristo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Morales" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Norosí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pinillos" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Regidor" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Río Viejo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Cristóbal" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Estanislao" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Fernando" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Jacinto" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Jacinto del Cauca" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Juan Nepomuceno" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Martín de Loba" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Pablo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Catalina" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Cruz de Mompox" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Rosa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Rosa del Sur" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Simití" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Soplaviento" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Talaigua Nuevo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tiquisio" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Turbaco" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Turbaná" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Villanueva" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Zambrano" }
                    );

                //Municipios de Boyacá
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Boyacá") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chíquiza" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chivatá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cómbita" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cucaita" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Motavita" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Oicatá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Samacá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Siachoque" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sora" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Soracá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sotaquirá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Toca" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tunja" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tuta" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ventaquemada" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chiscas" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Cocuy" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El espino" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guacamayas" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Güicán" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Panqueba" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Labranzagrande" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pajarito" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Paya" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pisba" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Berbeo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Campohermoso" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Miraflores" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Páez" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Eduardo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Zetaquira" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Boyacá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ciénaga" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Jenesano" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Nuevo Colón" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ramiriqui" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Rondón" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tibaná" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Turmequé" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Úmbita" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Viracachá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chinavita" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Garagoa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Macanal" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pachavita" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Luis de Gaceno" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa María" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Boavita" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Covarachía" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Uvita" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Mateo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sativanorte" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "SativaSur" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Soatá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Susacón" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tipacoque" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Briceño" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Buenavista" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Caldas" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chiquinquirá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Coper" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Victoria" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Maripí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Muzo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Otanche" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pauna" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Quípama" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Saboyá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Miguel de Sema" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Pablo de Borbur" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tunungúa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Almeida" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chivor" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guateque" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guayatá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Capilla" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Somondoco" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sutatenza" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tenza" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Arcabuco" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chitaraque" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Gachantivá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Moniquira" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ráquira" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sáchica" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San José de Pare" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Sofía" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santana" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sutamarchán" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tinjacá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Togüí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Villa de Leyva" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Aquitania" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cuítiva" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Firavitoba" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Gámeza" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Iza" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Mongua" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Monguí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Nobsa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pesca" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sogamoso" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tibasosa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tópaga" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tota" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Belén" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Busbanzá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cerinza" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Corrales" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Duitama" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Floresta" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Paipa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Rosa de Viterbo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tutazá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Betéitiva" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chita" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Jericó" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Paz de Río" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Socha" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Socotá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tasco" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cubará" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Boyacá" }
                    );

                //Municipios de Caldas
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Caldas") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Filadelfia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Merced" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Marmato" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Riosucio" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Supía" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Manzanares" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Marquetalia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Marulanda" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pensilvania" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Anserma" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Belalcázar" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Risaralda" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San José" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Viterbo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chinchiná" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Manizales" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Neira" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Palestina" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Villamaría" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Dorada" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Norcasia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Samaná" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Victoria" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Aguadas" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Aranzazu" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pácora" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Salamina" }
                    );

                //Municipios de Caquetá
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Caquetá") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Albania" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Belén de los Andaquínes" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cartagena del Chairá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Curillo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Doncello" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "el Paujil" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Florencia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Montanita" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Morelia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Milán" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Rico" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San José del Fragua" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San vicente del Caguán" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Solano" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Solita" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Valparaíso" }
                    );

                //Municipios de Casanare
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Casanare") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Aguazul" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chámeza" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Hato Corozal" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Salina" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Maní" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Monterrey" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Nunchía" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Orocué" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Paz de Ariporo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pore" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Recetor" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sabanalarga" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sácama" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Luis de Palenque" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Támara" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tauramena" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Trinidad" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Villanueva" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Yopal" }
                    );
                //Municipios de Cauca
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Cauca") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Buenos Aires" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Caloto" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Corinto" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guachené" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Miranda" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Padilla" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Tejada" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santander de Quilichao" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Suárez" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Villa Rica" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cajibío" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Tambo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Sierra" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Morales" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Piendamó" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Popayán" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Rosas" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sotará" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Timbío" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Almaguer" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Argelia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Balboa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Bolívar" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Florencia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Vega" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Mercaderes" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Patía" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Piamonte" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Sebastían" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Rosa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sucre" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guapi" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "López de Micay" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Timbiquí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Caldono" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Inzá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Jambaló" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Páez" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puracé-Coconuco" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Silvia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Toribío" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Totoró" }
                    );
                //Municipios de Cesar
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Cesar") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Valledupar" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Aguachica" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Agustín Codazzi" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Bosconia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chimichagua" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Copey" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Alberto" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Curumaní" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El paso" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Paz" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pueblo Bello" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Jagua de Ibirico" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chiriguaná" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Astrea" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Martín" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pelaya" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pailitas" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Gamarra" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Manaure Balcón del Cesar" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Río de Oro" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tamalameque" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Becerril" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Diego" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Gloria" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "González" }
                    );
                //Municipios de Chocó
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Chocó") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Acandí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Alto Baudó" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Atrato" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Bagadó" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Bahia Solano" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Bajo Baudó" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Bojayá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cértegui" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Condoto" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Cantón de San Pablo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Carmen de Atrato" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Carmen de Darién" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Litoral de San Juan" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Istmina" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Juradó" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Lloró" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Medio Atrato" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Medio Baudó" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Medio San Juan" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Nóvita" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Nuquí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Quibdó" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Río Iró" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Río Quito" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Riosucio" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San José del Palmar" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sipí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tadó" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Unguía" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Unión Panamericana" }
                    );
                //Municipios de Córdoba
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Córdoba") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }
                    );
                //Municipios de Cundinamarca
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Cundinamarca") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(

                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }
                    );
                //Municipios de Guainía
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Guainía") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }
                    );
                //Municipios de Guaviare
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Guaviare") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }
                    );

                //Municipios de Huila
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Huila") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }
                    );

                //Municipios de La Guajira
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("La Guajira") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }
                    );

                //Municipios de Magdalena
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Magdalena") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }
                    );

                //Municipios de Meta
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Meta") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }
                    );

                //Municipios de Nariño
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Nariño") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }, 
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }

                    );
                //Municipios de Norte de Santander
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Norte de Santander") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }
                    );

                //Municipios de Putumayo
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Putumayo") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }
                    );

                //Municipios de Quindío
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Quindío") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }
                    );

                //Municipios de Risaralda
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Risaralda") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }
                    );

                //Municipios de San Andrés y Providencia
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("San Andrés y Providencia") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }
                    );

                //Municipios de Santander
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Santander") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }
                   );

                //Municipios de Sucre
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Sucre") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }
                    );

                //Municipios de Tolima
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Tolima") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }
                   );

                //Municipios de Valle del Cauca
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Valle del Cauca") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }
                    );

                //Municipios de Vaupés
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Vaupés") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }
                    );

                //Municipios de Vichada
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Vichada") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "" }
                    );

                context.SaveChanges();
            }
        }
    }
}
