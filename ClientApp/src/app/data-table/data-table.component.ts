import { Component, Input, OnInit, OnChanges } from '@angular/core';

@Component({
  selector: 'data-table',
  templateUrl: './data-table.component.html',
  styleUrls: ['./data-table.component.css']
})

export class DataTableComponent implements OnInit,OnChanges{
  @Input() dataSource: any;
  @Input() columns: any;
  displayedColumns: string[] = ['firstName', 'lastName', 'score'];
  // listData: Array<any>;

  constructor() {
  }

  ngOnChanges() {
    console.log(this.dataSource);
  }

  ngOnInit() {
  }
  // onChangePage(dataUpdate: Array<any>) {
  //   this.listData = dataUpdate;
  // }
}