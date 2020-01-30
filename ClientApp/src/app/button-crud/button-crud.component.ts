import { Component, Input, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-button-crud',
  templateUrl: './button-crud.component.html',
  styleUrls: ['./button-crud.component.css']
})
export class ButtonCRUDComponent{
  @Input() data: any;


  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) { }

  add(){
    // return this.http.post()
  }

  public createStudent(){

  }

  public editStudent(){

  }

  public deleteStudent(){

  }

}
