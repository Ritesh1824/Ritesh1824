import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class CalculatorService {
  url = "http://localhost:6570/api/";
  constructor(private http:HttpClient) { }
  
  add(urlExt : String){
    return this.http.get(this.url+urlExt ,  { responseType: 'text' });
  }

}
