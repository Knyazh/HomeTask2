// See https://aka.ms/new-console-template for more information
double overageBudget = 20000000000;
Console.WriteLine("Budce :" + overageBudget);

int armyFee = 20;
int techFee = 10;


double totaArmyfee = overageBudget * armyFee / 100;
Console.WriteLine("Mudafie Nazirliyine :" + totaArmyfee);

double totalTechfee = overageBudget * techFee / 100;
Console.WriteLine("Yuksek Texnologiya Nazirliyine :" + totalTechfee);

double total = overageBudget - totalTechfee -  totalTechfee;
Console.WriteLine("Yerde Qalan Budce :" + total);