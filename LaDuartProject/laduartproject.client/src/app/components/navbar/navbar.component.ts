import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { CartComponent } from '../cart/cart.component';


@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent {

  constructor(public dialog: MatDialog) { }

  openDialog(): void {
    const dialogRef = this.dialog.open(CartComponent, {
      width: '400px',
    });
  }

}




