import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-value', // this fis use whenever you want to use this moduleS
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.css']
})
export class ValueComponent implements OnInit {

  values: any; // this can set any js object or data type.

  constructor(private Http: HttpClient) { }

  ngOnInit() {
    this.getValues();
  }

  getValues(){
    this.Http.get('https://localhost:44304/api/values').subscribe(response => {
       this.values = response;
    }, error => {console.log(error);
    });
  }

}
