using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace CS.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }
       public Pessoa(string nome, string sobrenome)
       {
        Nome = nome;
        
       }
       private string _nome = "";
       public string Nome 
            { 
                get => _nome.ToUpper();

                set{
                if(value == ""){
                    throw new ArgumentException("Invalido");
            
            }
            _nome = value;
       } 
       }   
       
       
       private string _idade = "";
       public string Idade { 
        get => _idade;
       
       
       set{
        
        if(!int.TryParse(value,out int num)){ 
         throw new ArgumentException("Idade inválida");
        
        }
       
        _idade = value;
       }
        }
       
       private string _birthday = "";
       public string Birthday { 
        
        get =>  _birthday;
       
       
       set{
        string formato = "dd-MM-yyyy";
        if(DateTime.TryParseExact(value, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out _)){
        }else{
            throw new ArgumentException("formato de Data inválido");
        }
        _birthday = value;
       } }
       
       private string _cpf = "";
       public string Cpf { 
        
        get => _cpf;
       
       
       set{
        if(long.TryParse(value,out _) is false){
            Console.WriteLine(int.TryParse(value,out _));
            throw new ArgumentException("Cpf inválido");
        }else if(value.Length != 11) {
            throw new ArgumentException("Cpf com quantidade inválida");
        }
        _cpf = value;
       } }

       public void dados(){
        Console.WriteLine($"Nome: {_nome} Birthday:{_birthday}({_idade}) Cpf:{_cpf}");
       }
    }
}