import { Component, Input } from '@angular/core';

@Component({
  selector: 'data-table',
  templateUrl: './data-table.component.html',
  styleUrls: ['./data-table.component.css']
})

export class DataTableComponent {
  @Input() dataSource: any;
  @Input() columns: any;

  listData: Array<any>;

  constructor() {
  }

  onChangePage(dataUpdate: Array<any>) {
    this.listData = dataUpdate;
  }
}