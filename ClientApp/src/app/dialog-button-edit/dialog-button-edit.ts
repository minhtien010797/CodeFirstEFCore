import { Component, Input, Inject } from "@angular/core";
import { MatDialogRef, MAT_DIALOG_DATA } from "@angular/material/dialog";
import { DialogData } from "../button-crud/button-crud.component";

@Component({
    selector: 'dialog-button-edit',
    templateUrl: 'dialog-button-edit.html',
  })
  export class DialogButtonEdit {
    dataModel: any;
    constructor(
      public dialogRef: MatDialogRef<DialogButtonEdit>,
      @Inject(MAT_DIALOG_DATA) public data: any) {
        this.dataModel = data;
      }
  
    onNoClick(): void {
      this.dialogRef.close();
    }
  }
  