import { Component, Input, OnInit, OnChanges, ViewChild } from '@angular/core';
import { SelectionModel } from '@angular/cdk/collections';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';

@Component({
  selector: 'data-table',
  templateUrl: './data-table.component.html',
  styleUrls: ['./data-table.component.css']
})

export class DataTableComponent implements OnChanges {
  @Input() dataSource: any;
  @Input() columns: any;
  listData: any;

  displayedColumns: string[] = ['select', 'firstName', 'lastName', 'score'];

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;

  selection = new SelectionModel<any>(true, [])

  constructor() {
  }

  ngOnChanges() {
    if (this.dataSource.length) {
      this.listData = new MatTableDataSource<any>(this.dataSource);
      this.listData.paginator = this.paginator;
    }
  }

  isAllSelected() {
    const numSelected = this.selection.selected.length;
    const numRows = this.listData.data.length;
    return numSelected === numRows;
  }

  masterToggle() {
    // this.isAllSelected() ?
    //     this.selection.clear() :
    //     this.dataSource.data.forEach(row => this.selection.select(row));
    
    if (this.isAllSelected()) {
      this.selection.clear()
    }
    this.dataSource.forEach((row: any) => this.selection.select(row));
  }

  checkboxLabel(row?: any): string {
    if (!row) {
      return `${this.isAllSelected() ? 'select' : 'deselect'} all`;
    }
    return `${this.selection.isSelected(row) ? 'deselect' : 'select'} row ${row.position + 1}`;
  }
}