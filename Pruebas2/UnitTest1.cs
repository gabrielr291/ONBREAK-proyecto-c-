using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BibliotecaClase;
using System.Collections.Generic;
using BibliotecaDALC;
namespace Pruebas2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { //3A
          //ARRANGE

            string rutPRUEBA = "1";
            string nom_contactoPRUEBA = "1";
            string razon_socialPRUEBA = "1";
            string correoPRUEBA = "1";
            string direccionPRUEBA = "1";
            string telefonoPRUEBA = "1";
            int idActividadEmpresaPRUEBA = 1;
            int IdTipoEmpresaPRUEBA = 1;

            //ACT
            BibliotecaClase.Cliente cl = new BibliotecaClase.Cliente()
            {
                Rut = rutPRUEBA,
                Nom_contacto = nom_contactoPRUEBA,
                Razon_social = razon_socialPRUEBA,
                Correo = correoPRUEBA,
                Direccion = direccionPRUEBA,
                Telefono = telefonoPRUEBA,
                idActividadEmpresa = idActividadEmpresaPRUEBA,
                IdTipoEmpresa = IdTipoEmpresaPRUEBA

            };


            //Assert
            Assert.IsNotNull(cl);

        }//Deberia fallar ya que esperabamos que el rut no se acepte sin su validacion
        [TestMethod]
        public void TestMethod2()
        { //3A
          //ARRANGE

            string rutPRUEBA = "1";
            string nom_contactoPRUEBA = null;
            string razon_socialPRUEBA = null;
            string correoPRUEBA = null;
            string direccionPRUEBA = null;
            string telefonoPRUEBA = null;
            int idActividadEmpresaPRUEBA = 1;
            int IdTipoEmpresaPRUEBA = 1;
            //ACT
            BibliotecaClase.Cliente cl = new BibliotecaClase.Cliente()
            {
                Rut = rutPRUEBA,
                Nom_contacto = nom_contactoPRUEBA,
                Razon_social = razon_socialPRUEBA,
                Correo = correoPRUEBA,
                Direccion = direccionPRUEBA,
                Telefono = telefonoPRUEBA,
                idActividadEmpresa = idActividadEmpresaPRUEBA,
                IdTipoEmpresa = IdTipoEmpresaPRUEBA

            };


            //Assert
            Assert.IsNull(cl);

        }
        [TestMethod]
        public void TestMethod3()
        { //3A
          //ARRANGE

            BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
            string ClienteConContrato = "11.813.711-6";
            bool realidad;

            //ACT
            realidad = con.ExisteClienteConContrato(ClienteConContrato);


            //Assert
            Assert.IsTrue(realidad);

        }
        [TestMethod]
        public void TestMethod4()
        {  //3A
           //ARRANGE

            BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
            string ClienteConContrato = "25/2";
            bool realidad;

            //ACT
            realidad = con.ExisteClienteConContrato(ClienteConContrato);


            //Assert
            Assert.IsTrue(realidad);

        }// no da

        [TestMethod]
        public void TestMethod5()
        { //3A
          //ARRANGE

            BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
            string ClienteConContrato = "11.813.711-6";
            List<BibliotecaClase.Contrato> realidad;

            //ACT
            realidad = con.cliConContrato(ClienteConContrato);


            //Assert
            Assert.IsNotNull(realidad);

        }


        //[TestMethod]
        //public void TestMethod6()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Cliente con = new BibliotecaClase.Cliente();
        //    string Cliente = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    con = con.Buscar(Cliente);


        //    //Assert
        //    Assert.IsNotNull(con);

        //}
        //[TestMethod]
        //public void TestMethod7()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Cliente con = new BibliotecaClase.Cliente();
        //    string dato = "11.813.711-6";
        //    BibliotecaClase.Cliente realidad;

        //    //ACT
        //    realidad = con.Buscar1(dato);


        //    //Assert
        //    Assert.IsNotNull(realidad);

        //}

        //[TestMethod]
        //public void TestMethod8()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}
        //[TestMethod]
        //public void TestMethod9()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}
        //[TestMethod]
        //public void TestMethod10()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}
        //[TestMethod]
        //public void TestMethod11()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}
        //[TestMethod]
        //public void TestMethod12()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}
        //[TestMethod]

        //public void TestMethod13()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}

        //[TestMethod]
        //public void TestMethod14()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}
        //[TestMethod]
        //public void TestMethod15()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}

        //[TestMethod]
        //public void TestMethod16()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}
        //[TestMethod]
        //public void TestMethod17()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}
        //[TestMethod]
        //public void TestMethod18()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}
        //[TestMethod]
        //public void TestMethod19()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}
        //[TestMethod]
        //public void TestMethod20()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}
        //[TestMethod]
        //public void TestMethod21()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}
        //[TestMethod]
        //public void TestMethod22()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}
        //[TestMethod]
        //public void TestMethod23()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}
        //[TestMethod]
        //public void TestMethod24()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}

        //[TestMethod]
        //public void TestMethod25()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}
        //[TestMethod]
        //public void TestMethod26()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}
        //[TestMethod]
        //public void TestMethod27()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}
        //[TestMethod]
        //public void TestMethod28()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}
        //[TestMethod]
        //public void TestMethod29()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}
        //[TestMethod]
        //public void TestMethod30()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}
        //[TestMethod]
        //public void TestMethod31()
        //{ //3A
        //  //ARRANGE

        //    BibliotecaClase.Contrato con = new BibliotecaClase.Contrato();
        //    string ClienteConContrato = "11.813.711-6";
        //    bool realidad;

        //    //ACT
        //    realidad = con.ExisteClienteConContrato(ClienteConContrato);


        //    //Assert
        //    Assert.IsTrue(realidad);

        //}

    }
}
