import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-data-table',
  templateUrl: './data-table.component.html',
  styleUrls: ['./data-table.component.css']
})

export class DataTableComponent {
  @Input() dataSource: any;
  @Input() columns: any;

  constructor() {
  }

  onChangePage(dataUpdate: Array<any>) {
    this.dataSource = dataUpdate;
  }
}