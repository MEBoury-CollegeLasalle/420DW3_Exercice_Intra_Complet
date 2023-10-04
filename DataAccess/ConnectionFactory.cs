using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DW3_Exercice_Intra_Test.DataAccess;
public class ConnectionFactory {
    private static SqlConnection? CONNECTION;

    public static SqlConnection GetConnection() {
        CONNECTION ??= new SqlConnection("Server=.\\SQL2022DEV;Integrated Security=true;TrustServerCertificate=true;Database=da3_exercices_intra;");
        return CONNECTION;
    }

}
