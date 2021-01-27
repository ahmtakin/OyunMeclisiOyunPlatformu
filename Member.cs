using System;
using System.Collections.Generic;
using System.Text;

namespace OyunMeclisi
{
    class Member
    {
        List<string> members = new List<string> { };
        List<string> userInput=new List<string> { };
        public void CheckNAdd(List<string> members,List<string> userInput,Member member)
        {
            if (member.TcNo==userInput[0])
            {
                if (member.FirstName == userInput[1])
                {
                    if (member.LastName == userInput[2])
                    {
                        if (member.BirthYear==userInput[3])
                        {
                            if (members.Contains(userInput[4])==false)
                            {
                                members.Add(userInput[4]);
                                member.NickName = userInput[4];
                                Console.WriteLine("Kayıt Başarılı. Hoşgeldiniz, " + member.NickName);
                            }
                            else
                            {
                                Console.WriteLine("kaydınızı yapamadık bu kullanıcı adı mevcut");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Kaydınızı yapamadık bu kriterlere uyan bir vatandaş yok");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Kaydınızı yapamadık bu kriterlere uyan bir vatandaş yok");
                    }
                }
                else
                {
                    Console.WriteLine("Kaydınızı yapamadık bu kriterlere uyan bir vatandaş yok");
                }
            }
            else
            {
                Console.WriteLine("Kaydınızı yapamadık bu kriterlere uyan bir vatandaş yok");
            }
        }  
        public void Delete(List<string> members, List<string> userInput)
        {
            Console.WriteLine("Kaydınız başarıyla silinmiştir... "+userInput[4]);
            members.Remove(userInput[4]) ;
        }

        public void Update(List<string> members, List<string> userInput,Member member,string NickNameChange)
        {
            members.Remove(userInput[4]);
            userInput[4] = NickNameChange;
            members.Add(userInput[4]);
            member.NickName = userInput[4];
            Console.WriteLine("Kullanıcı adı güncellendi... Yeni kullanıcı adınız: "+member.NickName);

        }
       
        public string NickName { get; set; }
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthYear { get; set; }
        



    }
}
