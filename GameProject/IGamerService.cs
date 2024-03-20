using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
   
    public interface IGamerService
    {
    public    void Add(Gamer gamer) {

            Console.WriteLine("Kayıt oldu ");
        }

     public   void Update(Gamer gamer) {


            Console.WriteLine("Kayıt Güncellendi ");

        }

    public    void Delete(Gamer gamer) {

            Console.WriteLine("Kayıt Silindi ");


        }


    }
}
