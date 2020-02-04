import { Component, Input, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import {MatDialog, MatDialogRef, MAT_DIALOG_DATA} from '@angular/material/dialog';

export interface DialogData {
  firstName: string;
  lastName: string;
  score: number
}

@Component({
  selector: 'app-button-crud',
  templateUrl: './button-crud.component.html',
  styleUrls: ['./button-crud.component.css']
})
export class ButtonCRUDComponent{
  @Input() data: any;
  
  firstName: string;
  lastName: string;
  score: number;

  dataInput: any;


  private headers = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  };

  constructor(public dialog: MatDialog, private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  openCreateForm(): void{
    const dialogRef = this.dialog.open(DialogButtonCreate, {
      width: '500px',
      data: {firstName: this.firstName, lastName: this.lastName, score: this.score}
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataInput = result;
      if(this.dataInput !== null)
      {
        this.http.post<any>(this.baseUrl + 'api/students',  this.dataInput, this.headers).subscribe(result => {
          console.log('Add new student successfully !!!!!');
        });
      }
      console.log(result);
      debugger;
    });
  }
  // public editStudent(){
  // }

  public deleteStudent(){
    this.http.delete<any>(this.baseUrl + 'api/students'+'/'+ id).subscribe(result => {
      console.log('Delete student successfully !!!!!');
    });
  }
}

@Component({
  selector: 'dialog-button-create',
  templateUrl: 'dialog-button-create.html',
})
export class DialogButtonCreate {

  constructor(
    public dialogRef: MatDialogRef<DialogButtonCreate>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData) {}

  onNoClick(): void {
    this.dialogRef.close();
  }
}