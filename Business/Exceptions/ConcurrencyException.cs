using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DW3_Exercice_Intra_Test.Business.Exceptions;
public class ConcurrencyException : Exception {
    public ConcurrencyException(DBConcurrencyException previous) 
        : base(
            $"Erreur de concurrence pour l'entrée #{previous.Row?.Field<int>("Id")}. " +
            $"Vos changements apportés à cette entrée ont été annulés.", 
            previous) { 
    }
}
