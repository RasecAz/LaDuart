import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { NavbarComponent } from '../navbar/navbar.component';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent {


  constructor(
    public dialogRef: MatDialogRef<CartComponent>) { }

  onNoClick(): void {
    this.dialogRef.close();
  }

}
