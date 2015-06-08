/*
 *  "JZRLib", Java Roguelike games development Library.
 *  Copyright (C) 2015 by Serg V. Zhdanovskih (aka Alchemist, aka Norseman).
 *
 *  This program is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */
package jzrlib.core;

/**
 *
 * @author Serg V. Zhdanovskih
 */
public final class Range implements Cloneable
{
    public int Min;
    public int Max;

    public Range()
    {
    }

    public Range(int min, int max)
    {
        this.Min = min;
        this.Max = max;
    }

    @Override
    public Range clone()
    {
        return new Range(this.Min, this.Max);
    }
}