using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio3.Models
{
    public class PersonaModel
    {
        //Propiedades: cuando se instancia una persona se puede hacer persona.Peso=valor

        public string Nombre { get; set; }
        public int Id { get; set; }
        public double Peso { get; set;}
        public double Estatura { get; set; }
        public double IMC { get; set; }
        public double salario { get; set; }
        public int edad { get; set; }
        public string escuela { get; set; }

        //Constructores (no es indispensable en este caso)

        //public PersonaModel() {
        //    this.Nombre = "Sin nombre";
        //    this.Id = 0;
        //    this.Peso = 0.0;
        //    this.Estatura = 0.0;
        //    this.IMC = 0.0;
        //}

        //public PersonaModel(int Id, string Nombre,double Peso, double Estatura, double IMC)
        //{
        //    this.Nombre = Nombre;
        //    this.Id = Id;
        //    this.Peso = Peso;
        //    this.Estatura = Estatura;
        //    this.IMC = IMC;
        //}

        private PersonaModel() {

        }

        public class PersonaModelBuilder{
            public PersonaModel persona;

            public class PersonaModelBuilderMayor {

                public PersonaModel personaMayor;

                public PersonaModelBuilderMayor(int edad) {
                    personaMayor.edad = edad;
                }
                public PersonaModelBuilderMayor setSalario(double salario) {
                    personaMayor.salario = salario;
                    return this;
                }

               
            }

            public PersonaModelBuilder(int Id) {
                persona = new PersonaModel();
                persona.Id = Id;
            }

            public PersonaModelBuilder setNombre(string nombre) {
                persona.Nombre = nombre;
                return this;
            }

            public PersonaModelBuilder setPeso(double peso) {
                persona.Peso=peso;
                return this;
            }

            public PersonaModelBuilder setEstatura(double estatura) {
                persona.Estatura=estatura;
                return this;
            }

            public PersonaModelBuilderMayor setEdadMayor(int edad) {
                PersonaModelBuilderMayor personaMayor = new PersonaModelBuilderMayor(edad);
                return personaMayor;
            }

            public PersonaModel build() {
                return persona;
            }

            
        } 
    }
}