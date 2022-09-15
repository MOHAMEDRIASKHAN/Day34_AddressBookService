// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
namespace AddressBookServiceDay34
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Address Book Service");


            Console.WriteLine("AddressBook_Using_Ado.Net ");
            AddressBookRepo abrepo = new AddressBookRepo();
            //abrepo.CheckConnection();
            AddressBookDetails abmodel = new AddressBookDetails();
            AddressBookDetails abmodel1 = new AddressBookDetails();
            AddressBookDetails delmodel = new AddressBookDetails();
            while (true)
            {
                Console.WriteLine("\nEnter Choice  \n1.AddContact \n2.EditContact \n3.DeleteContact \n4.RetriveStateorCity" +
                                  "\n5.SizeofBook\n6.SortPersonNameByCity\n7.identifyEachAddressbook\n8.CountByBookType\n9.Exit\n10.Display ");
                int choice = Convert.ToInt32(Console.ReadLine());
                try
                {
                    switch (choice)
                    {
                        case 1:
                            //AddressBookModel abmodel = new AddressBookModel();
                            abmodel.First_Name = "Riyas";
                            abmodel.Last_Name = "Khan";
                            abmodel.Address = "Pondy";
                            abmodel.City = "Puducherry";
                            abmodel.State = "Pondicherry";
                            abmodel.Phone_Number = "1234567890";
                            abmodel.Email = "riyas28@gmail.com";
                            abmodel.BookName = "MRK";
                            abmodel.AddressbookType = "family";
                            bool result = abrepo.AddContact(abmodel);

                            if (result)
                                Console.WriteLine("Record added successfully...");
                            else
                                Console.WriteLine("Some problem is there...");
                            Console.ReadKey();
                            break;
                        case 2:
                            // Update recods
                            //AddressBookModel abmodel1 = new AddressBookModel();
                            abmodel1.First_Name = "Uma";
                            abmodel1.Last_Name = "Princess";
                            abmodel1.City = "Singapore";
                            abmodel1.State = "Singapore";
                            abmodel1.Email = "umariyas@gmail.com";
                            abmodel1.BookName = "UMAPrincess";
                            abmodel1.AddressbookType = "office";
                            abrepo.EditContactUsingFirstName(abmodel1);
                            Console.ReadKey();
                            break;
                        case 3:
                            delmodel.First_Name = "radha";
                            abrepo.DeleteContactUsingName(delmodel);
                            Console.ReadKey();
                            break;
                        case 4:
                            abrepo.RetrieveContactFromPerticularCityOrState();
                            Console.ReadKey();
                            break;
                        case 5:
                            abrepo.AddressBookSizeByCityANDState();
                            Console.ReadKey();
                            break;
                        case 6:
                            abrepo.SortPersonNameByCity();
                            Console.ReadKey();
                            break;
                        case 7:
                            abrepo.identifyEachAddressbooktype();
                            Console.ReadKey();
                            break;
                        case 8:
                            abrepo.GetNumberOfContactsCountByBookType();
                            Console.ReadKey();
                            break;

                        case 9:
                            Environment.Exit(0);
                            break;
                        case 10:
                            abrepo.RetrieveContact();
                            break;
                        default:
                            Console.WriteLine("Enter The Valid Choise");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("please enter integer options only");
                }
            }
        }
    }
    }
