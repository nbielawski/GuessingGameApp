﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuessingGame.Models
{
    public class GameModel
    {

        [Required]
        [MaxLength(25, ErrorMessage = "The maximum name length is 25 characters.")]
        [Display(Name = "Player Name")]
        public string PlayerName { get; set; }

        [Range(1, 10, ErrorMessage ="Guess must be between 1 and 10")]
        public int Guess { get; set; }
    }
}