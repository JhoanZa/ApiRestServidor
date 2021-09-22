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
                    
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ayapel" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Buenavista" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Canalete" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cereté" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chimá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chinú" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ciénaga de Oro" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cotorra" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Apartada" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Los Córdobas" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Momil" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Montelíbano" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Montería" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Moñitos" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Planeta Rica" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pueblo Nuevo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Escondido" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Libertador" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Purísima" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sahagún" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Andrés de Sotaviento" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Antero" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Bernardo del Viento" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Carlos" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San José de Uré" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Pelayo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Cruz de Lorica" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tierralta" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tuchín" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Valencia" }
                    );
                //Municipios de Cundinamarca
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Cundinamarca") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(

                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chocontá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Machetá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Manta" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sesquilé" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Suesca" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tibirita" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Villapinzón" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Agua de Dios" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Girardot" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guataquí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Jerusalén" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Nariño" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Nilo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ricaurte" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tocaima" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Caparrapí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guaduas" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Salgar" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Albán" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Peña" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Vega" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Nimaima" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Nocaima" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Quebradanegra" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Francisco" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sasaima" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Supatá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Útica" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Vergara" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Villeta" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Gachalá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Gachetá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Gama" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guasca" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guatavita" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Junín" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Calera" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ubalá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Beltrán" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Bituima" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chaguaní" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guayabal de Síquima" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pulí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Juan de Rioseco" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Vianí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Medina" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Paratebueno" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cáqueza" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chipaque" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Choachí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Fómeque" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Fosca" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guayabetal" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Gutiérrez" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Quetame" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ubaque" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Une" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Peñón" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Palma" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pacho" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Paime" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Cayetano" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Topaipí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Villagómez" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Yacopí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cajicá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chía" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cogua" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cota" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Gachancipá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Nemocón" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sopó" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tabio" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tenjo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tocancipá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Zipaquirá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Bojacá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Rosal" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Facatativá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Funza" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Madrid" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Mosquera" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Subachoque" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Zipacón" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sibaté" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Soacha" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Arbeláez" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cabrera" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Fusagasugá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Granada" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pandi" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pasca" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Bernardo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Silvania" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tibacuy" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Venecia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Anapoima" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Anolaima" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Apulo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cachipay" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Colegio" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Mesa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Quipile" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Antonio del Tequendama" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tena" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Viotá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Carmen de Carupa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cucunubá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Fúquene" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guachetá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Lenguazaque" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Simijaca" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Susa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sutatausa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tausa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ubaté" }
                    );
                //Municipios de Guainía
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Guainía") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Barrancominas" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cacahual" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Inírida" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Guadalupe" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Morichal Nuevo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pana Pana" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Colombia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Felipe" }
                    );
                //Municipios de Guaviare
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Guaviare") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Calamar" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Retorno" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Miraflores" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San José del Guaviare" }
                    );

                //Municipios de Huila
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Huila") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Aipe" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Algeciras" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Baraya" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Campoalegre" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Colombia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Hobo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Íquira" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Neiva" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Palermo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Rivera" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa María" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tello" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Teruel" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Villavieja" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Yaguará" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Agrado" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Altamira" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Garzón" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Gigante" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guadalupe" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pital" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Suaza" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tarqui" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Argentina" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Plata" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Nátaga" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Paicol" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tesalia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Acevedo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Elías" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Isnos" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Oporapa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Palestina" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pitalito" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Saladoblanco" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Agustín" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Timaná" }
                    );

                //Municipios de La Guajira
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("La Guajira") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Albania" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Barracas" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Dibulla" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Distracción" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Molino" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Fonseca" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Hatonuevo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Jagua del Pilar" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Maicao" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Manaure" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Riohacha" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Juan del Cesar" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Uribia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Urumita" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Villanueva" }
                    );

                //Municipios de Magdalena
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Magdalena") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Algarrobo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Aracataca" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ariguaní" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cerro de San Antonio" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chibolo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ciénaga" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Concordia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Banco" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "el Pinón" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Retén" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Fundación" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guamal" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Nueva Granada" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pedraza" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pijiño del Carmen" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pivijay" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Plato" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pueblo Nuevo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Remolino" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sabanas de San Ángel" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Salamina" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Sebastián de Buenavista" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Ana" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Bárbara de Pinto" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Marta" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Zenón" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sitionuevo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tenerife" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Zapayán" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Zona Bananera" }
                    );

                //Municipios de Meta
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Meta") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Acacías" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Barranca de Upía" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cabuyaro" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Castilla La Nueva" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cubarral" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cumaral" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Calvario" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Castillo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Dorado" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Fuente de Oro" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Granada" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guamal" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Macarena" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Uribe" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Lejanías" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Mapiripán" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Mesetas" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Concordia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Gaitán" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Lleras" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto López" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Rico" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Restrepo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Carlos de Guaroa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Juan de Arama" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Juanito" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Martín" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Villavicencio" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Vista Hermosa" }
                    );

                //Municipios de Nariño
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Nariño") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Barbacoas" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Charco" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Francisco Pizarro" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Tola" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Magüí Payán" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Mosquera" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Olaya Herrera" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Roberto Payán" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Bárbara" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tumaco" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Aldana" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Contadero" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Córdoba" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cuaspud" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cumbal" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Funes" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guachucal" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Gualmatán" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Iles" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ipiales" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Potosí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerres" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pupiales" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Albán" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Arboleda" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Belén" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Colón" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Rosario" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Tablón de Gómez" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Cruz" }, 
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Unión" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Leiva" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Policarpa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Bernardo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Lorenzo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Pablo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Pedro de Cartago" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Taminango" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Buesaco" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chachagüí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Consacá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Peñol" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Tambo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Florida" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Nariño" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pasto" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sandoná" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tangua" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Yacuanquer" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ancuya" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cumbitara" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guaitarilla" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Imués" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Llanada" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Linares" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Los Andes" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Mallama" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ospina" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Providencia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ricaurte" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Samaniego" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santacruz" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sapuyes" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Túquerres" }

                    );
                //Municipios de Norte de Santander
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Norte de Santander") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Arboledas" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cucutilla" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Gramalote" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Lourdes" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Salazar de Las Palmas" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santiago" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Villa Caro" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cúcuta" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Zulia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Los Patios" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Santander" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Cayetano" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Villa del Rosario" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Bucarasica" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Tarra" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sardinata" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tibú" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ábrego" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cáchira" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Convención" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Carmen" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Hacarí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Esperanza" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Playa de Belén" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ocaña" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Calixto" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Teorama" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cácota" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chitagá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Mutiscua" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pamplona" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pamplonita" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santo Domingo de Silos" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Bochalema" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chinácota" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Durania" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Herrán" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Labateca" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ragonvalia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Toledo" }
                    );

                //Municipios de Putumayo
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Putumayo") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Colón" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Mocoa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Orito" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Asís" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Caicedo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Guzmán" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Leguízamo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Francisco" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Miguel" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santiago" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sibundoy" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Valle del Guamuez" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Villagarzón" }
                    );

                //Municipios de Quindío
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Quindío") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Armenia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Buenavista" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Calarcá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Circasia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Córdoba" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Filandia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Génova" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Tebaida" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Montenegro" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pijao" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Quimbaya" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Salento" }
                    );

                //Municipios de Risaralda
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Risaralda") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Apía" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Balboa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Belén de Umbria" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Dosquebradas" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Gúatica" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Celia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Virginia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Marsella" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Mistrató" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pereira" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pueblo Rico" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Quinchía" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Rosa de Cabal" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santuario" }
                    );

                //Municipios de San Andrés y Providencia
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("San Andrés y Providencia") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Andrés" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Providencia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Catalina" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cayos" }
                    );

                //Municipios de Santander
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Santander") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Aguada" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Albania" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Aratoca" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Barbosa" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Barichaca" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Barrancabermeja" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Betulia" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Bolívar" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Bucaramanga" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cabrera" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "California" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Capitanejo" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Carcasí" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cepitá" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cerrito" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Charalá" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Charta" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chima" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chipatá" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cimitarra" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Concepción" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Confines" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Contratación" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Coromoro" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Curití" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Carmen de Chucurí" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Guacamayo" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Peñón" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Playón" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Encino" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Enciso" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Florián" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Floridablanca" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Galán" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Gámbita" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Girón" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guaca" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guadalupe" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guapotá" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guavatá" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Güepsa" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Hato" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Jesús María" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Jordán" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Belleza" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Paz" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Landázuri" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Lebrija" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Los Santos" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Macaravita" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Málaga" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Matanza" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Mogotes" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Molagavita" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ocamonte" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Oiba" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Onzaga" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Palmar" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Palmas del Socorro" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Páramo" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Piedecuesta" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pinchote" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puente Nacional" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Parra" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Wilches" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Rionegro" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sabana de Torres" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Andrés" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Benito" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Gil" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Joaquín" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San José de Miranda" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Miguel" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Vicente de Chucurí" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Bárbara" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Helena de Opón" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Simacota" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Socorro" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Suaita" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sucre" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Suratá" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tona" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Valle de San José" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Vélez" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Vetas" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Villanueva" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Zapatoca" }
                   );

                //Municipios de Sucre
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Sucre") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guaranda" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Majagual" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sucre" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chalán" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Colosó" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Morroa" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ovejas" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sincelejo" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Coveñas" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Palmito" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Onofre" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santiago de Tolú" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Toluviejo" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Buenavista" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Corozal" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Roble" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Galeras" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Los Palmitos" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sampúes" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Juan de Betulia" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Pedro" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sincé" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Caimito" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Unión" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Benito Abad" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Marcos" }
                    );

                //Municipios de Tolima
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Tolima") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Alvarado" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Anzoátegui" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cajamarca" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Coello" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Espinal" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Flandes" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ibagué" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Piedras" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Rovira" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Luis" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Valle de San Juan" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Casabianca" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Herveo" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Lérida" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Líbano" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Murillo" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Isabel" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Venadillo" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Villahermosa" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ambalema" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Armero" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Falan" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Fresno" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Honda" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Sebastián de Mariquita" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Palocabildo" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Carmen de Apicalá" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cunday" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Icononzo" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Melgar" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Villarrica" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ataco" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Chaparral" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Coyaima" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Natagaima" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ortega" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Planadas" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Rioblanco" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Roncesvalles" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Antonio" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Alpujarra" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Dolores" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guamo" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Prado" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Purificación" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Saldaña" },
                   new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Suárez" }
                   );

                //Municipios de Valle del Cauca
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Valle del Cauca") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Alcará" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Andalucia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ansermanuevo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Argelia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Bolívar" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Buenaventura" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Buga" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Bugalagrande" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Caicedonia" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cali" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Calima - El Darién" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Candelaria" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cartago" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Dagua" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Águila" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Cairo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Cerrito" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "El Dovio" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Florida" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ginebra" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Guacarí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Jamundí" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Cumbre" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Unión" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Victoria" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Obando" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Palmira" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pradera" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Restrepo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Riofrío" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Roldanillo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "San Pedro" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Sevilla" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Toro" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Trujillo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Tuluá" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Ulloa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Versalles" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Vijes" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Yotoco" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Yumbo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Zarzal" }
                    );

                //Municipios de Vaupés
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Vaupés") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Carurú" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Mitú" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Pacoa" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Papunaua" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Taraira" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Yavaraté" }
                    );

                //Municipios de Vichada
                departamentoL = from departamento in context.Departamentos where departamento.Nombre.Equals("Vichada") select departamento;
                Codigo = departamentoL.First().IdDepartamento;

                context.Municipios.AddRange(
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Cumaribo" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "La Primavera" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Puerto Carreño" },
                    new Municipio { IdDepartamento = Codigo, NombreMunicipio = "Santa Rosalia" }
                    );

                context.SaveChanges();
            }
        }
    }
}
