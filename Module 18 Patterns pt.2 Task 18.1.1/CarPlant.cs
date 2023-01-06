using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18_Patterns_pt._2_Task_18._1._1
{
    /// <summary>
    /// Автомобильный завод
    /// </summary>
    class CarPlant
    {
        /// <summary>
        /// Запуск процесса постройки
        /// </summary>
        public void Construct(Conveyor conveyor)
        {
            conveyor.BuildFrame();
            conveyor.BuildEngine();
            conveyor.BuildWheels();
            conveyor.BuildDoors();
        }
    }
}
