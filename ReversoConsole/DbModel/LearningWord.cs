﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ReversoConsole.DbModel
{
    class LearningWord
    {
        public int Id { get; set; }
        public Word WordToLearn { get; set; }
        public int Level { get; set; }
        public DateTime? LastTime { get; set; }

    }
}
