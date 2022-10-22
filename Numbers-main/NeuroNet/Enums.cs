using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers.NeuroNet
{
    //Режим работы памяти
    enum MemoryMode
    {
        GET,
        SET
    }


    //Тип нейрона
    enum NeuroType
    {
        Hidden,
        Output
    }


    //Режим работы сети
    enum NetworkMode
    {
        Train,      //обучение
        Test,       //тестирование
        Recognize   //распознавание 
    }
}
