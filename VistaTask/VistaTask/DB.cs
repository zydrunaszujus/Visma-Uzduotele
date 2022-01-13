using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VismaTask
{
    public static class DB//siuntinesim failus per sita duombaze
    {//Meeting klases iskvietimas i DB
        const string FILE_NAME = "duomenys.json";
        public static List<Meeting>Meetings=new List<Meeting>();//bendravimas su failu
        public static void SaveChanges()//DB issaugojiumui
        {
            var  textData=JsonConvert.SerializeObject(Meetings);//Meetings pavercia i teksta
            File.WriteAllText(FILE_NAME, textData);//iraso i faila paversta Meetings
        }
        public static void Load()//DB uzkrauti
        {
            if (File.Exists(FILE_NAME))//tikrinam ar toks failas yra,jei tokis failas yra
            {//tada uzkaraunam//
                var textDataFromFile=File.ReadAllText(FILE_NAME);//nuskaitom duomenis is failo
                List<Meeting> objectData = (List<Meeting>)JsonConvert.DeserializeObject<List<Meeting>>(textDataFromFile);//atverciam i objekta
                Meetings = objectData;//Priskiriam Meeting lista Meetings objekta.
            }
            //JsonConvert.SerializeObject vercia objekta i teksta arba lista
        }//DeSerializeObject- vercia tekstai objekta
    }
}
