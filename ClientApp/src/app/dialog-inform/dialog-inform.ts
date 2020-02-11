import { Component, Inject } from "@angular/core";

import { MatDialogRef, MAT_DIALOG_DATA } from "@angular/material/dialog";

@Component({
    selector: 'dialog-inform',
    templateUrl: 'dialog-inform.html',
  })
  export class DialogInform {
    constructor(
      public dialogRef: MatDialogRef<DialogInform>, 
      @Inject(MAT_DIALOG_DATA) public data: any) { }
  
    onNoClick(): void {
      this.dialogRef.close();
    }
  }