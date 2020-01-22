import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-button-crud',
  templateUrl: './button-crud.component.html',
  styleUrls: ['./button-crud.component.css']
})
export class ButtonCRUDComponent{
  @Input() data: any;


  constructor() { }

  add(){
    return this.http.post()
  }

  public createStudent(){

  }

  public editStudent(){

  }

  public deleteStudent(){

  }

}
