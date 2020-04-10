using System;

namespace Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            DocumentWorker document = new DocumentWorker();
            if (key == "111")
            {
                Console.WriteLine("Basic version");
                document.OpenDocument();
                document.EditDocument();
                document.SaveDocument();


            }
            else if (key == "222")
            {
                document = new ProDocumentWorker();
                Console.WriteLine("Pro vesion");
                document.EditDocument();
                document.SaveDocument();

            }
            else if (key == "333")
            {
                Console.WriteLine("Exprot vesion");
                document.SaveDocument();

            }
        }
    }
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");

        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранить документ");
        }

    }
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступа в версии Эксперт");
        }
    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }




}

