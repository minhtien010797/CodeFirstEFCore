import { Component, Input, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { MatDialog, MatDialogRef, MAT_DIALOG_DATA } from '@angular/material/dialog';

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
  @Input() rowSelected: any;

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
          console.log('Add new student successfully !!!!!');
        });
      }
    });
  }

  public deleteStudent() {
    const dialogRef = this.dialog.open(DialogButtonDelete);

    dialogRef.afterClosed().subscribe(confirmresult => {
      if (confirmresult) {
        if (this.rowSelected.length !== 0) {
          this.rowSelected.forEach(std => {
            console.log("AAAAAAAAAAAA");
            // this.http.delete<any>(this.baseUrl + 'api/students' + '/' + std.id).subscribe(result => {
            //   console.log('Delete student successfully !!!!!');
            // });
          });
        }
        else {
          this.dialog.open(DialogError);
        }
        console.log("Delete confirm is approved by user.");
      }
      else {
        console.log("Delete confirm is cancelled by user.");
      }
    })
  }

  public editStudent() {
    if (this.rowSelected.length == 1) {
      const dialogRef = this.dialog.open(DialogButtonEdit);

      
    }
    else {
      this.dialog.open(DialogError);
    }
  }
}


@Component({
  selector: 'dialog-button-create',
  templateUrl: 'dialog-button-create.html',
})
export class DialogButtonCreate {

  constructor(
    public dialogRef: MatDialogRef<DialogButtonCreate>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData) { }

  onNoClick(): void {
    this.dialogRef.close();
  }
}

@Component({
  selector: 'dialog-button-delete',
  templateUrl: 'dialog-button-delete.html',
})
export class DialogButtonDelete {
  constructor(@Inject(MAT_DIALOG_DATA) public data: any) { }
}

@Component({
  selector: 'dialog-button-edit',
  templateUrl: 'dialog-button-edit.html',
})
export class DialogButtonEdit {
  constructor(
    public dialogRef: MatDialogRef<DialogButtonEdit>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData) { }

  onNoClick(): void {
    this.dialogRef.close();
  }
}

@Component({
  selector: 'dialog-error',
  templateUrl: 'dialog-error.html',
})
export class DialogError {
  constructor(
    public dialogRef: MatDialogRef<DialogError>,
    @Inject(MAT_DIALOG_DATA) public data: DialogData) { }

  onNoClick(): void {
    this.dialogRef.close();
  }
}