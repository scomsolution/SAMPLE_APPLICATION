using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMPLE_APPLICATION
{
    class DependecyInjection
    {
        //1st Way

        #region Method Injection in C#

        public void Call_Method_Injection()
        {
            client cn = new client();
            cn.run(new servic());
        }

        public interface Iset
        {
            void print();
        }
        public class servic : Iset
        {
            public void print()
            {
                Console.WriteLine("print........");
            }
        }
        public class client
        {
            private Iset _set;
            public void run(Iset serv)
            {
                this._set = serv;
                Console.WriteLine("start");
                this._set.print();
            }
        }


        #endregion

        #region Property Injection in C#

        public void Call_Property_Injection()
        {
            EventLogWriter elw = new EventLogWriter();
            atul at = new atul();
            at.notify(elw, "to logg");
        }

        public interface INofificationAction
        {
            void ActOnNotification(string message);
        }
        class atul
        {
            INofificationAction task = null;
            public void notify(INofificationAction at, string messages)
            {
                this.task = at;
                task.ActOnNotification(messages);
            }
        }
        class EventLogWriter : INofificationAction
        {
            public void ActOnNotification(string message)
            {
                // Write to event log here
            }
        }

        #endregion

        #region Constructor Injection in C#

        public void Call_Constructor_Injection()
        {
            constructorinjection cs = new constructorinjection(new format());
            cs.print();
        }

        public interface text
        {
            void print();
        }
        class format : text
        {
            public void print()
            {
                Console.WriteLine(" here is text format");
            }
        }
        // constructor injection
        public class constructorinjection
        {
            private text _text;
            public constructorinjection(text t1)
            {
                this._text = t1;
            }
            public void print()
            {
                _text.print();
            }
        }

        #endregion

        //2nd Way

        #region Method Injection in C#

        public interface IService3
        {
            void Serve();
        }
        public class Service13 : IService3
        {
            public void Serve() { Console.WriteLine("Service1 Called"); }
        }
        public class Service23 : IService3
        {
            public void Serve() { Console.WriteLine("Service2 Called"); }
        }
        public class Client3
        {
            private IService3 _service;
            public void Start(IService3 service)
            {
                service.Serve();
            }
        }

        public void Call_Method_Injection_2()
        {
            //creating object
            Service13 s1 = new Service13();

            Client3 client = new Client3();
            client.Start(s1); //passing dependency
                              //TO DO:

            Service23 s2 = new Service23();
            client.Start(s2); //passing dependency
        }



        #endregion

        #region Property Injection in C#
        public interface IService2
        {
            void Serve();
        }
        public class Service12 : IService2
        {
            public void Serve() { Console.WriteLine("Service1 Called"); }
        }
        public class Service22 : IService2
        {
            public void Serve() { Console.WriteLine("Service2 Called"); }
        }
        public class Client2
        {
            private IService2 _service;
            public IService2 Service
            {
                set { this._service = value; }
            }
            public void ServeMethod() { this._service.Serve(); }
        }
        public void Call_Property_Injection_2()
        {
            //creating object
            Service12 s1 = new Service12();

            Client2 client = new Client2();
            client.Service = s1; //passing dependency
                                 //TO DO:

            Service22 s2 = new Service22();
            client.Service = s2; //passing dependency
        }


        #endregion

        #region Constructor Injection in C#

        public interface IService
        {
            void Serve();
        }
        public class Service1 : IService
        {
            public void Serve() { Console.WriteLine("Service1 Called"); }
        }
        public class Service2 : IService
        {
            public void Serve() { Console.WriteLine("Service2 Called"); }
        }
        public class Client
        {
            private IService _service;
            public Client(IService service)
            {
                this._service = service;
            }
            public void ServeMethod() { this._service.Serve(); }
        }


        public void Call_Constructor_Injection_2()
        {
            //creating object
            Service1 s1 = new Service1();
            //passing dependency
            Client c1 = new Client(s1);
            //TO DO:

            Service2 s2 = new Service2();
            //passing dependency
            c1 = new Client(s2);
        }



        #endregion


    }
}
