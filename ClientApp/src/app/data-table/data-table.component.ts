import { Component, Input, OnInit, OnChanges, ViewChild, SimpleChange, SimpleChanges } from '@angular/core';
import { SelectionModel } from '@angular/cdk/collections';
import { MatPaginator } from '@angular/material/paginator';
import { MatTableDataSource } from '@angular/material/table';
import { debug } from 'util';

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

  ngOnChanges(changes: SimpleChanges) {
    if (changes.dataSource) {
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
    if (this.isAllSelected()) {
      this.selection.clear()
    }
    else{
      this.dataSource.forEach((row: any) => this.selection.select(row));
    }
  }

  checkboxLabel(row?: any): string {
    if (!row) {
      return `${this.isAllSelected() ? 'select' : 'deselect'} all`;
    }
    return `${this.selection.isSelected(row) ? 'deselect' : 'select'} row ${row.position + 1}`;
  }
}