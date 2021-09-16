import { Component, OnInit } from '@angular/core';
import {CalculatorService} from 'src/app/calculator.service';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent implements OnInit {

  constructor(private calculate:CalculatorService) { }

  ngOnInit() {
  }

  
  isRoman : boolean =true;
  input:string = '';
  result:string = '';
  urlExt : string = ""  ;      

  
  public switchCal(){
   
    this.isRoman = !this.isRoman;
    this.allClear();
     
    }
  pressNum(num: string) {
    //Do not allow dots more than once 
   if(this.getlastKey()  === '.' && num === '.'){
      return;
    }
    this.input = this.input + num
   } 
 
 
  pressOperator(op: string) {
     //Do not allow operators more than once and do not allow '.' at the end
    if ( this.input =="" || this.input.indexOf(op)>0 || this.getlastKey() === "+" || this.getlastKey() === ".")  {
      return;
    }
   
    this.input = this.input + op
  }
 
   getlastKey(){
     return this.input[this.input.length - 1];
   }
 
  clear() {
    if (this.input !="" ) {
      this.input=this.input.substr(0, this.input.length-1)
    }
  }
 
  allClear() {
    this.result = '';
    this.input = '';
  }
 
  calcAnswer() {
    if(this.isRoman){
      this.urlExt = "addRoman/"+this.input.split('+').join('/');
    }else{
      this.urlExt = "addDecimal/"+this.input.split('+').join('/');
    }
 
   this.calculate.add(this.urlExt).subscribe((rs)=>{
    this.result = rs.toString();
    console.warn("result",rs);
    }
    )
    this.urlExt = "";
  }
 
  getAnswer() {
    if(this.getlastKey()  === '.'){
      return;
    }
    this.calcAnswer();
     if (this.input=="0") this.input="";
  }

}
