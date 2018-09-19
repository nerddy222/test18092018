import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {
  num1:number;
  num2:number;
  constructor(public navCtrl: NavController,private http:HttpClient) {

  }

  witdrawCash(){
    this.http.get<Number>("http://localhost:5000/api/Calculater/"+ this.num1)
    .subscribe(data => console.log(data));
  }

}
