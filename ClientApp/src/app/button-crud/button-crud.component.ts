import { Component, Input, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { DialogButtonCreate } from '../dialog-button-create/dialog-button-create';
import { DialogButtonDelete } from '../dialog-button-delete/dialog-button-delete';
import { DialogButtonEdit } from '../dialog-button-edit/dialog-button-edit';
import { DialogInform } from '../dialog-inform/dialog-inform';
import { withModule } from '@angular/core/testing';

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
export class ButtonCRUDComponent {
  @Input() data: any;
  @Input() selectedRows: any;

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

  openCreateForm(): void {
    const dialogRef = this.dialog.open(DialogButtonCreate, {
      width: '500px',
      data: { firstName: this.firstName, lastName: this.lastName, score: this.score }
    });

    dialogRef.afterClosed().subscribe(result => {
      this.dataInput = result;
      if (this.dataInput !== null) {
        this.http.post<any>(this.baseUrl + 'api/students', this.dataInput, this.headers).subscribe(result => {
          this.dialog.open(DialogInform, {
            width: '500px',
            data:{title: 'Inform', content:'Add new student successfully !!!!!'}
          });
        });
      }
    });
  }

  public deleteStudent() {
    const dialogRef = this.dialog.open(DialogButtonDelete);

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        if (this.selectedRows.length !== 0) {
          this.selectedRows.forEach(std => {
            this.http.delete<any>(this.baseUrl + 'api/students' + '/' + std.id).subscribe(result => {
              this.dialog.open(DialogInform, {
                width: '500px',
                data:{title: 'Inform', content:'Delete student successfully !!!!!'}
              });
            });
          });
        }
        else {
          this.dialog.open(DialogInform, {
            width: '500px',
            data:{title: 'Error', content:'You must choose one or more student to delete !!!!'}
          });
        }
        console.log("Delete confirm is approved by user.");
      }
      else {
        console.log("Delete confirm is cancelled by user.");
      }
    })
  }

  public editStudent() {
    if (this.selectedRows.length == 1) {
      const dialogRef = this.dialog.open(DialogButtonEdit, {
        width: '500px',
        data: { firstName: this.selectedRows[0].firstName, lastName: this.selectedRows[0].lastName, score: this.selectedRows[0].score }
      });

      dialogRef.afterClosed().subscribe(dataEdit => {
        if (dataEdit) {
          this.selectedRows.forEach(std => {
            dataEdit.id = std.id;
            this.http.put<any>(this.baseUrl + 'api/students' + '/' + std.id, dataEdit).subscribe(result => {
              this.dialog.open(DialogInform, {
                width: '500px',
                data:{title: 'Inform', content:'Edit student successfully !!!!!'}
              });
              this.reloadPage();
            });
          });
        }
      })
    }
    else {
      this.dialog.open(DialogInform, {
        width: '500px',
        data:{title: 'Error', content:'You can not choose more 2 students to edit !!!!'}
      });

      return 
    }
  }

  public reloadPage(){
    return this.http.get<any>(this.baseUrl + 'api/students').subscribe(result=>{
      this.data = result;
    });
  }

}
  