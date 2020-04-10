using System;

namespace Console_Application
{
    class Program
    {
        //     static void Main(string[] args)
        //     {
        //         string key = Console.ReadLine();
        //         DocumentWorker document = new DocumentWorker();
        //         if (key == "111")
        //         {
        //             Console.WriteLine("Basic version");
        //             document.OpenDocument();
        //             document.EditDocument();
        //             document.SaveDocument();


        //         }
        //         else if (key == "222")
        //         {
        //             document = new ProDocumentWorker();
        //             Console.WriteLine("Pro vesion");
        //             document.EditDocument();
        //             document.SaveDocument();

        //         }
        //         else if (key == "333")
        //         {
        //             Console.WriteLine("Exprot vesion");
        //             document.SaveDocument();

        //         }
        //     }
        // }
        // class DocumentWorker
        // {
        //     public virtual void OpenDocument()
        //     {
        //         Console.WriteLine("Документ открыт");

        //     }
        //     public virtual void EditDocument()
        //     {
        //         Console.WriteLine("Редактирование документа");
        //     }
        //     public virtual void SaveDocument()
        //     {
        //         Console.WriteLine("Сохранить документ");
        //     }

        // }
        // class ProDocumentWorker : DocumentWorker
        // {
        //     public override void EditDocument()
        //     {
        //         Console.WriteLine("Документ отредактирован");
        //     }
        //     public override void SaveDocument()
        //     {
        //         Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступа в версии Эксперт");
        //     }
        // }
        // class ExpertDocumentWorker : ProDocumentWorker
        // {
        //     public override void SaveDocument()
        //     {
        //         Console.WriteLine("Документ сохранен в новом формате");
        //     }
        static void Main(string[] args)
        {
            Player player=new Player();
            player.Play();
            player.Pause();
            player.Stop();
            Recorder rec = new Recorder();
            rec.Record();
            rec.Pause();
            rec.Stop();
            Console.ReadKey();

        }
        interface IPlay
        {
            void Play();
            void Pause();
            void Stop();
        }
        class Player : IPlay
        {
            public void Play()
            {
                Console.WriteLine("Play");
            }

            public void Pause()
            {
                Console.WriteLine("Pause");
            }

            public void Stop()
            {
                Console.WriteLine("Stop");
            }
        }
        interface IRecodable
        {
            void Record();
            void Pause();
            void Stop();
        }
        class Recorder:IRecodable
        {
            public void Pause()
            {
                Console.WriteLine("Pause");
            }

            public void Record()
            {
                Console.WriteLine("Record");
            }

            public void Stop()
            {
                Console.WriteLine("Stop");
            }
        }

    }





}

