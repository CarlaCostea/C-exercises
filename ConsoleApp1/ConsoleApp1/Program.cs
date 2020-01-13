using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* reading input data
            string inputData = Console.ReadLine();
            decimal amount = Convert.ToDecimal(inputData);
            inputData = Console.ReadLine();
            decimal interestRatePerYear = Convert.ToDecimal(inputData);
            inputData = Console.ReadLine();
            int totalMonths = Convert.ToInt32(inputData);
            inputData = Console.ReadLine();<DirectedGraph xmlns="http://schemas.microsoft.com/vs/2009/dgml">
  <Nodes>
    <Node Id="(@1 @2)" Visibility="Hidden" />
    <Node Id="(@3 Namespace=ConsoleApp1 Type=Program)" Category="CodeSchema_Class" CodeSchemaProperty_IsInternal="True" CommonLabel="Program" Icon="Microsoft.VisualStudio.Class.Internal" IsDragSource="True" Label="Program" SourceLocation="(Assembly=file:///C:/Users/carla/source/repos/ConsoleApp1/ConsoleApp1/Program.cs StartLineNumber=4 StartCharacterOffset=10 EndLineNumber=4 EndCharacterOffset=17)" />
  </Nodes>
  <Links>
    <Link Source="(@1 @2)" Target="(@3 Namespace=ConsoleApp1 Type=Program)" Category="Contains" />
  </Links>
  <Categories>
    <Category Id="CodeSchema_Class" Label="Class" BasedOn="CodeSchema_Type" Icon="CodeSchema_Class" />
    <Category Id="CodeSchema_Type" Label="Type" Icon="CodeSchema_Class" />
    <Category Id="Contains" Label="Contains" Description="Whether the source of the link contains the target object" IsContainment="True" />
  </Categories>
  <Properties>
    <Property Id="CodeSchemaProperty_IsInternal" Label="Is Internal" Description="Flag to indicate the method is 'Internal'" DataType="System.Boolean" />
    <Property Id="CommonLabel" DataType="System.String" />
    <Property Id="Icon" Label="Icon" DataType="System.String" />
    <Property Id="IsContainment" DataType="System.Boolean" />
    <Property Id="IsDragSource" Label="IsDragSource" Description="IsDragSource" DataType="System.Boolean" />
    <Property Id="Label" Label="Label" Description="Displayable label of an Annotatable object" DataType="System.String" />
    <Property Id="SourceLocation" Label="Start Line Number" DataType="Microsoft.VisualStudio.GraphModel.CodeSchema.SourceLocation" />
    <Property Id="Visibility" Label="Visibility" Description="Defines whether a node in the graph is visible or not" DataType="System.Windows.Visibility" />
  </Properties>
  <QualifiedNames>
    <Name Id="Assembly" Label="Assembly" ValueType="Uri" />
    <Name Id="File" Label="File" ValueType="Uri" />
    <Name Id="Namespace" Label="Namespace" ValueType="System.String" />
    <Name Id="Type" Label="Type" ValueType="System.Object" />
  </QualifiedNames>
  <IdentifierAliases>
    <Alias n="1" Uri="Assembly=$(VsSolutionUri)/ConsoleApp1/ConsoleApp1.csproj" />
    <Alias n="2" Uri="File=$(VsSolutionUri)/ConsoleApp1/Program.cs" />
    <Alias n="3" Uri="Assembly=$(ae1382c9-ebe7-4f12-b7eb-3f56569bfd63.OutputPathUri)" />
  </IdentifierAliases>
  <Paths>
    <Path Id="ae1382c9-ebe7-4f12-b7eb-3f56569bfd63.OutputPathUri" Value="file:///C:/Users/carla/source/repos/ConsoleApp1/ConsoleApp1/bin/Debug/netcoreapp3.0/ConsoleApp1.dll" />
    <Path Id="VsSolutionUri" Value="file:///C:/Users/carla/source/repos/ConsoleApp1" />
  </Paths>
</DirectedGraph>
            int currentMonth = Convert.ToInt32(inputData);*/
            string inputData = Console.ReadLine();
            //int m = Convert.ToInt32(inputData);
            int sum = 0;
            if (inputData == "x")
            {
                Console.WriteLine(0);
            }
            else
            {
                sum += Convert.ToInt32(inputData);
                int m= Convert.ToInt32(inputData);
                while (true)
                {
                    string inputdata = Console.ReadLine();
                    if (inputdata == "x") 
                    { break; }

                    int Y = Convert.ToInt32(inputdata);
                    sum += Y;

                } 
                
                Console.WriteLine(sum);

            }

        }
    }
}
