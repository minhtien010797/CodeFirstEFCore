import { Component, Input, OnInit, OnChanges, ViewChild, SimpleChange, SimpleChanges } from '@angular/core';
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
  selectedRows: any[]=[];

  displayedColumns: string[] = ['select', 'firstName', 'lastName', 'score'];

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;

  selection = new SelectionModel<any>(true, [])

  constructor() {
  }

  ngOnChanges(changes: SimpleChanges) {
    if (changes.dataSource) {
      this.listData = new MatTableDataSource<any>(this.dataSource);
      this.listData.paginator = this.paginator;
      this.selectedRows = this.selection.selected;
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
    else {
      this.dataSource.forEach((row: any) => this.selection.select(row));
    }
  }

  checkboxLabel(row?: any): string {
    this.selectedRows = this.selection.selected;
    if (!row) {
      return `${this.isAllSelected() ? 'select' : 'deselect'} all`;
    }
    else {
      return `${this.selection.isSelected(row) ? 'deselect' : 'select'} row ${row.position + 1}`;
    }
  }

  addItem(row?: any){
    this.selectedRows = this.selection.selected;
  }

}