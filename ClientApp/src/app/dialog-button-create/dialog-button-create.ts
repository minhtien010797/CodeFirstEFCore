import { Component, Inject } from "@angular/core";
import { MatDialogRef, MAT_DIALOG_DATA } from "@angular/material/dialog";
import { DialogData } from "../button-crud/button-crud.component";

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